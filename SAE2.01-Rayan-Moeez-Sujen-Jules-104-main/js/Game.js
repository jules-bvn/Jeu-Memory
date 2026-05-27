import { imageCollections } from './ImageCollection.js';
import { ApiService } from './ApiService.js';

export class Game {
  constructor(gestionnaireDOM) {
    this.dom = gestionnaireDOM; 
    
    this._id = null;
    this.cartes = [];
    this.cartesRetournees = [];
    this.pairesTrouvees = 0;
    this.totalPaires = 0;
    
    this.secondes = 0;
    this.mouvements = 0; 
    this.erreurs = 0; 
    this.indicesUtilises = 0; 
    this.intervalleChrono = null;
    this.timerFastMode = null; 
    
    this.estVerrouille = false; 
    
    this.modeJeu = 'normal'; 
    this.nomJoueur = '';
    this.nomJoueur2 = '';
    this.tourJoueur = 1;
    this.scoreJ1 = 0;
    this.scoreJ2 = 0;
    
    this.auFini = null; 
  }

  demarrerPartie(id, nomJoueur, difficulte, nomCollection, imagesPersonnalisees, modeJeu, nomJoueur2) {
    this._id = id;
    this.nomJoueur = nomJoueur;
    this.nomJoueur2 = nomJoueur2 || "Joueur 2";
    this.difficulte = difficulte;
    this.modeJeu = modeJeu;
    
    this.cartesRetournees = [];
    this.pairesTrouvees = 0;
    this.estVerrouille = false;
    this.secondes = 0;
    this.mouvements = 0;
    this.erreurs = 0;
    this.indicesUtilises = 0;
    this.tourJoueur = 1;
    this.scoreJ1 = 0;
    this.scoreJ2 = 0;

    const nombreDePaires = { easy: 4, medium: 6, hard: 8 };
    this.totalPaires = nombreDePaires[difficulte];

    this.cartes = this.genererPaquet(nomCollection, this.totalPaires, imagesPersonnalisees);
    
    this.dom.afficherJeu();
    this.dom.configurerHUD(this.modeJeu, this.nomJoueur, this.nomJoueur2);

    if (this.modeJeu === '1vs1') {
      this.dom.mettreAJourScores1vs1(0, 0);
      this.dom.mettreAJourTour(1, this.nomJoueur);
    } else {
      this.dom.mettreAJourPairesRestantes(this.totalPaires);
      this.dom.mettreAJourChrono(0);
      this.dom.mettreAJourMouvements(0); 
      this.dom.mettreAJourErreurs(0); 
    }

    this.dom.creerCartes(this.cartes, this.gererClicCarte.bind(this));
    
    if (this.modeJeu !== '1vs1') {
      this.intervalleChrono = setInterval(() => {
        this.secondes++;
        this.dom.mettreAJourChrono(this.secondes);
      }, 1000);
    }
  }

  genererPaquet(nomCollection, nombrePairesDemande, imagesPersonnalisees) {
    let imagesDeBase = [];
    if (nomCollection === 'personnalisee' && imagesPersonnalisees.length > 0) {
      imagesDeBase = imagesPersonnalisees.slice(0, nombrePairesDemande);
    } else {
      // SÉCURITÉ ANTI-CRASH : Si le HTML envoie "animaux" au lieu de "LEC", on prend la 1ère collection dispo au lieu de planter
      const collectionValide = imageCollections[nomCollection] || Object.values(imageCollections)[0];
      imagesDeBase = collectionValide.slice(0, nombrePairesDemande);
    }

    let paquetDeCartes = [...imagesDeBase, ...imagesDeBase]; 
    for (let i = paquetDeCartes.length - 1; i > 0; i--) {
      const j = Math.floor(Math.random() * (i + 1));
      [paquetDeCartes[i], paquetDeCartes[j]] = [paquetDeCartes[j], paquetDeCartes[i]];
    }
    return paquetDeCartes.map((element, index) => ({ ...element, identifiantUnique: index }));
  }

  remelangerPlateau() {
    this.estVerrouille = true;
    const cartesNonTrouvees = Array.from(this.dom.plateauJeu.querySelectorAll('.card:not(.trouvee)'));
    
    cartesNonTrouvees.forEach(c => {
      c.classList.remove('flip');
      c.querySelector('.card-back').classList.add('hidden');
    });

    setTimeout(() => {
      // Utilisation de data-uid pour traquer la carte peu importe son mélange 
      const donneesCible = cartesNonTrouvees.map(c => {
        const uid = parseInt(c.dataset.uid);
        return this.cartes.find(carte => carte.identifiantUnique === uid);
      });

      for (let i = donneesCible.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [donneesCible[i], donneesCible[j]] = [donneesCible[j], donneesCible[i]];
      }

      cartesNonTrouvees.forEach((c, i) => {
        // ON MET A JOUR L'UID DANS LE HTML !
        c.dataset.uid = donneesCible[i].identifiantUnique;

        const backFace = c.querySelector('.card-back');
        const imgEl = backFace.querySelector('img');
        if (imgEl) {
          imgEl.src = donneesCible[i].url;
          imgEl.alt = donneesCible[i].name;
        }
        
        const nouveauNoeud = c.cloneNode(true);
        c.parentNode.replaceChild(nouveauNoeud, c);
        nouveauNoeud.addEventListener('click', () => this.gererClicCarte(nouveauNoeud, donneesCible[i]));
      });
      
      this.estVerrouille = false;
    }, 500); 
  }

  utiliserSabotage() {
    if (this.modeJeu !== '1vs1' || this.estVerrouille || this.pairesTrouvees === this.totalPaires) return;
    
    if (this.tourJoueur === 1) {
      if (this.scoreJ1 < 2) { alert("Il te faut 2 points pour saboter l'adversaire !"); return; }
      this.scoreJ1 -= 2;
    } else {
      if (this.scoreJ2 < 2) { alert("Il te faut 2 points pour saboter l'adversaire !"); return; }
      this.scoreJ2 -= 2;
    }
    
    this.dom.mettreAJourScores1vs1(this.scoreJ1, this.scoreJ2);
    this.remelangerPlateau();
  }

  utiliserIndice() {
    if (this.estVerrouille || this.pairesTrouvees === this.totalPaires) return;
    this.estVerrouille = true; 
    this.indicesUtilises++; 
    
    if (this.modeJeu === '1vs1') {
      if (this.tourJoueur === 1) this.scoreJ2++; else this.scoreJ1++;
      this.dom.mettreAJourScores1vs1(this.scoreJ1, this.scoreJ2);
    } else {
      this.secondes += 15; 
      this.dom.mettreAJourChrono(this.secondes);
    }

    const cartesMasquees = Array.from(this.dom.plateauJeu.querySelectorAll('.card:not(.trouvee):not(.flip)'));
    cartesMasquees.forEach(carteEl => {
      carteEl.classList.add('flip');
      carteEl.querySelector('.card-back').classList.remove('hidden');
    });

    setTimeout(() => {
      cartesMasquees.forEach(carteEl => {
        carteEl.classList.remove('flip');
        carteEl.querySelector('.card-back').classList.add('hidden');
      });
      this.estVerrouille = false; 
    }, 1500);
  }

  gererClicCarte(elementCarte, donneesCarte) {
    if (this.estVerrouille || elementCarte.classList.contains('flip') || elementCarte.classList.contains('trouvee')) {
      return;
    }

    elementCarte.classList.add('flip');
    elementCarte.querySelector('.card-back').classList.remove('hidden');
    this.cartesRetournees.push({ element: elementCarte, donnees: donneesCarte });

    if (this.cartesRetournees.length === 1 && this.modeJeu === 'fast') {
      this.timerFastMode = setTimeout(() => {
        if (this.cartesRetournees.length === 1) { 
          const carteRatee = this.cartesRetournees[0].element;
          carteRatee.classList.remove('flip');
          carteRatee.querySelector('.card-back').classList.add('hidden');
          this.cartesRetournees = [];
          this.erreurs++;
          this.dom.mettreAJourErreurs(this.erreurs);
        }
      }, 2000); 
    }

    if (this.cartesRetournees.length === 2) {
      if (this.timerFastMode) clearTimeout(this.timerFastMode); 
      this.verifierCorrespondance();
    }
  }

  verifierCorrespondance() {
    this.estVerrouille = true; 
    
    this.mouvements++;
    if (this.modeJeu !== '1vs1') this.dom.mettreAJourMouvements(this.mouvements);

    const [carte1, carte2] = this.cartesRetournees;

    if (carte1.donnees.id === carte2.donnees.id) {
      setTimeout(() => {
        let couleurAura = "#4ade80"; 
        if (this.modeJeu === '1vs1') couleurAura = this.tourJoueur === 1 ? "#4ade80" : "#f87171";

        carte1.element.style.boxShadow = `0 0 15px ${couleurAura}`; 
        carte2.element.style.boxShadow = `0 0 15px ${couleurAura}`;
        carte1.element.classList.add('trouvee');
        carte2.element.classList.add('trouvee');

        this.pairesTrouvees++;
        
        if (this.modeJeu === '1vs1') {
          if (this.tourJoueur === 1) this.scoreJ1++; else this.scoreJ2++;
          this.dom.mettreAJourScores1vs1(this.scoreJ1, this.scoreJ2);
        } else {
          this.dom.mettreAJourPairesRestantes(this.totalPaires - this.pairesTrouvees);
        }

        this.cartesRetournees = [];
        this.estVerrouille = false;

        if (this.pairesTrouvees === this.totalPaires) {
          this.terminerPartie(true);
        } 
        else if (this.modeJeu === 'chaos') {
          this.remelangerPlateau(); 
        }

      }, 500);
    } else {
      
      this.erreurs++; 
      if (this.modeJeu !== '1vs1') this.dom.mettreAJourErreurs(this.erreurs);

      setTimeout(() => {
        carte1.element.classList.remove('flip');
        carte2.element.classList.remove('flip');
        carte1.element.querySelector('.card-back').classList.add('hidden');
        carte2.element.querySelector('.card-back').classList.add('hidden');
        
        if (this.modeJeu === '1vs1') {
          this.tourJoueur = this.tourJoueur === 1 ? 2 : 1;
          this.dom.mettreAJourTour(this.tourJoueur, this.tourJoueur === 1 ? this.nomJoueur : this.nomJoueur2);
        }

        this.cartesRetournees = [];
        this.estVerrouille = false;
      }, 1000);
    }
  }

  async terminerPartie(estVictoire = false) {
    if (this.intervalleChrono) clearInterval(this.intervalleChrono); 
    if (this.timerFastMode) clearTimeout(this.timerFastMode);
    
    const pairesRestantes = this.totalPaires - this.pairesTrouvees;

    try {
      await ApiService.mettreAJourResultat(this._id, pairesRestantes);
    } catch (erreur) {
      console.warn('Erreur API :', erreur);
    }

    if (this.auFini) {
      this.auFini({
        estVictoire: estVictoire,
        temps: this.secondes,
        mouvements: this.mouvements, 
        erreurs: this.erreurs, 
        indices: this.indicesUtilises,
        difficulte: this.difficulte,
        nomJoueur: this.nomJoueur,
        nomJoueur2: this.nomJoueur2,
        mode: this.modeJeu,
        scoreJ1: this.scoreJ1,
        scoreJ2: this.scoreJ2
      });
    }
  }
}
