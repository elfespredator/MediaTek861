
Portofolio: https://elfespredator.github.io/newporot/portofolio.html

MediaTek86 — Application de gestion du personnel
Contexte
Application de bureau développée pour le réseau MediaTek86, qui gère les médiathèques de la Vienne.
Développée par un technicien développeur junior de l'ESN InfoTech Services 86.
L'application permet de gérer le personnel de chaque médiathèque, leur affectation à un service et leurs absences.

Fonctionnalités

Connexion sécurisée (login + mot de passe hashé SHA2)
Affichage de la liste du personnel
Ajout, modification, suppression d'un personnel
Affichage des absences d'un personnel (ordre chronologique inversé)
Ajout, modification, suppression d'une absence
Contrôle des chevauchements d'absences


Prérequis

Windows 10 / 11
WampServer (MySQL + Apache)
.NET Framework 4.7.2 ou supérieur


Installation
1. Base de données

Installer WampServer
Importer le fichier mediatek86.sql dans phpMyAdmin
L'utilisateur userMediatek (pwd: Mediatek86!) est créé automatiquement par le script

2. Application

Lancer le fichier MediaTek86Setup.msi
Suivre les étapes de l'installeur


Identifiants de test
LoginMot de passetesttest

Structure du projet (MVC)
MediaTek86/
├── bddmanager/         ← Connexion BDD (singleton)
│   └── BddManager.cs
├── controller/         ← Contrôleur MVC
│   └── PersonnelController.cs
├── dal/                ← Accès aux données
│   └── PersonnelDal.cs
├── model/              ← Classes métier
│   ├── Absence.cs
│   ├── Motif.cs
│   ├── Personnel.cs
│   └── Service.cs
├── vue/                ← Interfaces graphiques
│   ├── FrmConnexion.cs
│   ├── FrmPersonnel.cs
│   └── FrmAbsences.cs
└── mediatek86.sql      ← Script BDD complet

Diagramme de paquetages
MediaTek86
├── vue          → controller
├── controller   → dal
├── dal          → bddmanager
├── dal          → model
└── bddmanager   → MySQL

Auteur
Développé dans le cadre de l'atelier 2 — BTS SIO
ESN InfoTech Services 86 / Réseau MediaTek86
