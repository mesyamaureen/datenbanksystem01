# datenbanksystem01
## How to setup git repo in local computer:
### Prepare repository folder
1) Create a folder in local drive (mine is on my desktop) name: `yourname_datenbanksystem01`
2) Double click the folder
### Configure Email and Username for Github
3) Right click anywhere inside the folder
4) Choose `Git Bash Here`
5) The Command Line Interface (CLI) should show up (the one with the MINGW64 on it)
6) Type directly after $ sign `git config --global user.email *your email for Github*` and hit Enter on keyboard
7) A new line should show up
8) Type directly after $ sign on new line `git config --global user.name "`your username`"`and hit Enter
### Configuring SSH Key for Github account
9) Now we are going to add a public SSH Key to your Github account
10) Type directly after $ sign on new line `ssh-keygen` and hit Enter
11) When prompted to enter file to save, don't type anything and hit Enter
12) When prompted to enter passphrase, don't type anything and hit Enter
13) The key is being generated. Only continue once a new line (with a new $) is available
14) To link the SSH Key from your computer with your Github account, you need to first copy the content of the `.pub` file
15) To do so, type this in a new line exactly `cat ~/.ssh/id_rsa.pub`
16) The response should start with `ssh-rsa` this is your public SSH Key
17) Select everything from `ssh-rsa` until the end of the random key (just before the space and your computer's name) and copy
18) Go back to Github website and go to your Github account Settings (top right icon, then go to Settings)
19) Choose `SSH and GPG Keys` on the left side of the page
20) And click `New SSH Key`
21) Type in whatever name you want the title to be (something like "YourName"'s "YourComputerModel")
22) Paste the SSH Key inside the Key box and press `Add SSH Key` at the bottom of the page
23) If everything is as it should be, a new SSH Key should be saved on your Github account
### Cloning the repository to your local computer
24) Go back to the repository page on Github website
25) Click on `Clone or Download` button
26) Make sure it's `Clone with SSH`, there is a toggle on the top right corner to change from HTTPS to SSH and vice versa
27) Click on the copy to clipboard icon
28) Go back to the CLI
29) Type directly after $ sign on new line `git clone ` and paste the clone link from Github and hit Enter on keyboard
30) The git Repo should have been succesfully cloned. To check this, open the folder on Windows Explorer, there should be a new folder under the repo's name inside the directory made in step 1
### Check whether or not the repository on your computer is up-to-date
31) We need to move to the `master` branch of the repository. There are two ways to do so
32a) The cooler CLI way: type in a new line on Gitbash `cd ` "Folder name (in this case "datenbanksystem01" referring to the repo name)". You should directly able to see the word `(master)` right next to the directory line
32b) The simpler GUI way: double click the folder of the cloned repo in Windows Explorer and redo step 3 and 4
33) Type in Gitbash `git status` to check your files.
34) Whatever response you get from step 33, it is always a good practice to update your local folder with the one on Github, even though nothing might have changed (Do this before you do anything else) in which you type `git pull`

## How to work with git
Any Visual Studio file related to this project should be saved inside the repository folder (datenbanksystem01)
### Cheatsheets
1) `git status` : To check any changes in the repository folder
2) `git pull` : To download the actual file or changes in Github
3) `git add --a` : To add all changes made in the repository folder that will be pushed to Github
4) `git commit -m "enter any message about the changes made"` : Only do this after number 3! To add valuable information about what was changed
5) `git push` : To upload all changes and information to Github
