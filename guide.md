# Pour récuperer le projet

Installer Git for Windows, en particulier Git Bash : https://gitforwindows.org/

Ouvrir Git Bash et se placer dans le dossier ou vous voulez recuperer le projet avec la commande `cd`.
Par exemple pour moi ça donne :

```
cd D:Unity/Projects
```

Recupérer le projet via Github : 

```
git clone https://github.com/GaelleMarais/geometry-shooter-game
```

# Pour participer au projet

Après une session de travail, pour mettre en ligne les modifications apportées au projet.
Ouvrir Git Bash et se placer dans le dossier de travail avec la commande `cd`

```
cd D:Unity/Projects/geometry-shooter-game
```

Verifier que vous etes à jour sur la derniere version : 

```
git pull
```

Regardez le statut de votre repo avec la commande :

```
git status
```

Les fichiers qui ont été modifiés par rapport à la dernière fois sont en rouges.

Utilisez la commande `git add` pour ajouter les fichiers modifiés que vous voulez mettre en ligne
Par exemple :

```
git add fichier1.ext fichier2.ext 
```

Vérifiez avec `git status`que les fichiers que vous voulez mettre à jour apparaissent en vert
( a priori ce sera toujours tous les fichiers )
Pour ajouter directement tous les fichiers : 

```
git add *
```

Soumettre les modifications

```
git commit -m "Un messag de commit ici"
```

Mettre en ligne les soumissions 

```
git push
```
