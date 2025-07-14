# 🎮 Tower Defense Multiplayer (Unity + Photon Fusion)

> Un jeu mobile 2D en vue isométrique de type **tower defense multijoueur** développé avec **Unity** et **Photon Fusion**.

![Unity](https://img.shields.io/badge/Engine-Unity_6-blue?logo=unity)
![Platform](https://img.shields.io/badge/Platform-Android-green?logo=android)
![License](https://img.shields.io/badge/License-À_définir-lightgrey)
![Status](https://img.shields.io/badge/Status-En_développement-yellow)

---

## 🚀 Objectifs du projet

- Développer un gameplay tower defense coopératif ou compétitif
- Créer une structure propre, scalable et bien organisée
- Support Android avec version gratuite de Unity
- Intégration réseau via Photon Fusion
- Projet versionné sur GitHub pour collaboration fluide

---

## 🛠️ Technologies utilisées

| Outil / Techno         | Usage                          |
|------------------------|--------------------------------|
| **Unity 6**            | Moteur principal (2D isométrique) |
| **Photon Fusion**      | Multijoueur temps réel         |
| **C#**                 | Langage principal              |
| **Git / GitHub**       | Contrôle de version & collaboration |
| **Visual Studio Code** | Éditeur de code                |

---

## 🗂️ Structure du projet (provisoire)

\`\`\`
Assets/
├── Game/              → Logique gameplay (tours, ennemis, vagues)
├── Network/           → Scripts liés à Photon Fusion
├── UI/                → Interface utilisateur
├── Scenes/            → Scènes Unity
├── Scripts/           → Utilitaires, helpers
├── Resources/         → Données embarquées (sprites, prefabs)
\`\`\`

---

## 🔄 Workflow Git (à 2+)

- 🔵 Base de développement : `dev`
- 🔀 Ne pas développer directement sur `main`
- 🧪 Pour chaque tâche :
  1. Créer une branche `feature/ma-feature`
  2. Développer et pusher : `git push origin feature/ma-feature`
  3. Créer une **pull request vers `dev`**
  4. Mergée = ✅ tâche validée
- ✅ `main` ne reçoit que du code stable/testé

---

## 📱 Plateforme cible

- **Android** (builds via Unity Android Build Support)
- Compatible avec d'autres plateformes à terme (iOS ? Web ?)

---

## 🤝 Contributeurs

| Nom              | Rôle                   |
|------------------|------------------------|
| Myself Fake      | (à ajouter)            |
| Myself Real      | (à ajouter)            |

---

## 📌 À faire (prochaines étapes)

- [ ] Ajouter Photon Fusion au projet
- [ ] Créer les premières scènes de test
- [ ] Mettre en place le système de vague + tour
- [ ] Synchroniser les joueurs via réseau
- [ ] Créer la première map prototype
- [ ] Publier une démo jouable Android

---

## 📝 Licence

Projet privé pour le moment. Licence à définir.
