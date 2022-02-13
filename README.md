# ParallaxGame2D

Parallax Game é um jogo onde o personagem deve evitar que os obstáculos passem por ele, caso o ultrapasse, será fim de jogo, o jogo também termina se o jogador for atingidido por algum projétil inimigo. O objetivo do jogador é derrotar o máximo de inimigos que conseguir e assim, bater os seus recordes.

O jogo possui os seguintes diferenciais:

* O projétil disparado do player possui animação;
* O player possui animações de: parado, movimento, pulo e morte;
* Existem 3 tipos de inimigos, todos tem uma animação de movimento e de morte;
Além do desafio de não deixar os inimigos ultrapassarem até a esquerda da tela, o jogador também tem o desafio de desviar dos projéteis dos inimigos, podendo desviar, pulando ou atirando no projétil;
* Cada inimigo possui quantidade diferente de vida, onde o soldado pequeno precisa de 1 tiro para ser destruído, a torre oval precisa de 2 e o gigante de 5, onde cada um possui velocidades diferentes;
* Os inimigos surgem aleatoriamente de 3 spawners, onde cada um spawna em tempos diferentes sendo setado o tempo de 2 e 3 segundos.
* Foi incluído um menu inicial para o jogo;
* Foi incluído a opção de pausar o jogo;
* Quando o jogador é morto ou o inimigo ultrapassar a margem esquerda, os spawners param de funcionar e os inimigos que já foram sumonados são destruídos ao cruzar a margem, evitando a criação de objetos desnecessários;
* Os scripts foram os:
  * Player;
  * PlayerBullet;
  * Enemy;
  * EnemyBullet;
  * EnemySpawn;
  * UIController;
  * MainMenu;
  * Parallax;

As artes dos sprites dos modelos do cenário e personagens foram utilizados da assetStore;

<img src="https://media.giphy.com/media/fMPfkl8cg8yoGDjMGx/giphy.gif" width="480" height="270" />
<img src="https://media3.giphy.com/media/JGgYYODQYSXrQ0t0Xw/giphy.gif" width="480" height="270" />

