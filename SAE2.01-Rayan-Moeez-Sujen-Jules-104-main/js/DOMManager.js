
export class DOMManager {
  constructor() {
    this.plateauJeu = document.querySelector('.game-board');
    this.affichageChrono = document.getElementById('affichageChrono');
    this.affichagePaires = document.getElementById('compteurPaires');
    this.affichageMouvements = document.getElementById('affichageMouvements'); 
    this.affichageErreurs = document.getElementById('affichageErreurs'); 
    
    this.panneauFormulaire = document.getElementById('panneauFormulaire');
    this.zoneJeu = document.getElementById('zoneJeu');
    this.panneauClassement = document.getElementById('panneauClassement');

    //éléments HUD 1vs1
    this.hudSolo = document.getElementById('hud-solo');
    this.hud1vs1 = document.getElementById('hud-1vs1');
    this.scoreJ1El = document.getElementById('scoreJ1');
    this.scoreJ2El = document.getElementById('scoreJ2');
    this.nomJ1HUD = document.getElementById('nomJ1HUD');
    this.nomJ2HUD = document.getElementById('nomJ2HUD');
    this.affichageTour = document.getElementById('affichageTour');
    
    this.boutonIndice = document.getElementById('boutonIndice');
    this.boutonSabotage = document.getElementById('boutonSabotage'); 
    this.lecteurYoutube = document.getElementById('lecteurYoutube'); 
  }

  creerCartes(images, auClicSurCarte) {
    this.plateauJeu.innerHTML = ''; 

    images.forEach((image, index) => {
      const carte = document.createElement('div');
      carte.className = 'card'; 
      carte.dataset.index = index; 

      //Permet de tracer la carte pour le remélange
      carte.dataset.uid = image.identifiantUnique;

      carte.innerHTML = `
        <div class="card-inner">
          <div class="card-front" style="border: none !important; background: transparent !important; padding: 0 !important; overflow: hidden; border-radius: 0.5rem;">
            <img src="./assets/images/ARRIERE/logokc.png" alt="Logo KC" 
                 style="display: block; width: 100%; height: 100%; object-fit: cover; border-radius: 0.5rem;" 
                 onerror="this.style.display='none'; this.parentNode.style.background='var(--color-bg-card-front)'; this.parentNode.style.border='2px solid var(--color-border-card)'; this.parentNode.innerHTML='<span style=\\'font-size:3rem; color:rgba(255,255,255,0.4); display:flex; justify-content:center; align-items:center; width:100%; height:100%\\'>?</span>'">
          </div>
          
          <div class="card-back hidden" style="border: none !important; background: transparent !important; padding: 0 !important; overflow: hidden; border-radius: 0.5rem;">
            <img src="${image.url}" alt="${image.name}" 
                 style="display: block; width: 100%; height: 100%; object-fit: cover; border-radius: 0.5rem;">
          </div>
        </div>
      `;

      carte.addEventListener('click', () => auClicSurCarte(carte, image));
      this.plateauJeu.appendChild(carte);
    });
  }

  lancerMusiqueYoutube(url) {
    // Evite le crash si la balise est absente du HTML
    if (!this.lecteurYoutube) return;
    
    this.lecteurYoutube.innerHTML = ''; 
    if (!url) return;
    
    const regExp = /^.*(youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=|\&v=)([^#\&\?]*).*/;
    const match = url.match(regExp);
    
    if (match && match[2].length === 11) {
      const videoId = match[2];
      this.lecteurYoutube.innerHTML = `<iframe width="1" height="1" src="https://www.youtube.com/embed/${videoId}?autoplay=1&loop=1&playlist=${videoId}" allow="autoplay" style="display:none;"></iframe>`;
    }
  }

  configurerHUD(mode, pseudo1, pseudo2) {
    if (mode === '1vs1') {
      this.hudSolo.classList.add('hidden');
      this.hud1vs1.classList.remove('hidden');
      this.nomJ1HUD.textContent = pseudo1;
      this.nomJ2HUD.textContent = pseudo2;
      this.boutonIndice.textContent = "Indice (+1 pt Adv.)";
      this.boutonSabotage.classList.remove('hidden'); 
    } else {
      this.hudSolo.classList.remove('hidden');
      this.hud1vs1.classList.add('hidden');
      this.boutonIndice.textContent = "Indice (+15s)";
      this.boutonSabotage.classList.add('hidden'); 
    }
  }

  mettreAJourScores1vs1(score1, score2) {
    this.scoreJ1El.textContent = score1;
    this.scoreJ2El.textContent = score2;
  }

  mettreAJourTour(numeroJoueur, nomJoueur) {
    this.affichageTour.textContent = `Tour : ${nomJoueur}`;
    if (numeroJoueur === 1) {
      this.affichageTour.style.borderColor = '#4ade80';
      this.affichageTour.style.color = '#4ade80';
    } else {
      this.affichageTour.style.borderColor = '#f87171';
      this.affichageTour.style.color = '#f87171';
    }
  }

  mettreAJourChrono(secondes) {
    const min = Math.floor(secondes / 60).toString().padStart(2, '0');
    const sec = (secondes % 60).toString().padStart(2, '0');
    this.affichageChrono.textContent = `${min}:${sec}`;
  }

  mettreAJourPairesRestantes(compte) { this.affichagePaires.textContent = compte; }
  mettreAJourMouvements(compte) { this.affichageMouvements.textContent = compte; }
  mettreAJourErreurs(compte) { if(this.affichageErreurs) this.affichageErreurs.textContent = compte; }

  afficherJeu() {
    this.panneauFormulaire.classList.add('hidden');
    this.panneauClassement.classList.add('hidden');
    this.zoneJeu.classList.remove('hidden');
  }

  afficherFormulaire() {
    this.zoneJeu.classList.add('hidden');
    this.panneauClassement.classList.add('hidden');
    this.panneauFormulaire.classList.remove('hidden');
    if (this.lecteurYoutube) this.lecteurYoutube.innerHTML = ''; 
  }

  afficherClassement(difficulte, contenuHtml) {
    this.zoneJeu.classList.add('hidden');
    this.panneauFormulaire.classList.add('hidden');
    this.panneauClassement.classList.remove('hidden');
    const etiquette = document.getElementById('etiquetteDifficulte');
    if (etiquette && difficulte) etiquette.textContent = difficulte;
    const corps = document.getElementById('corpsClassement');
    if (corps && contenuHtml) corps.innerHTML = contenuHtml;
  }
}
