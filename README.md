# Trabalho02

Gabriel, Sara e Paloma!

Criamos um programa que joga um “caça palavras”, esse caça palavras possui regras diferentes.
Primeiro, vamos gerar o tabuleiro respeitando a geração a seguir:

A ou D      	E ou F      	B ou C
G ou I ou U  	H ou J ou V	  K ou L
M ou O ou Q 	N ou T ou P	  R ou S ou Z

Agora com o tabuleiro pronto, vamos ao problema.

Regras:

- O jogo consiste em um caça palavras em que as letras podem estar em qualquer direção em qualquer ordem (vide imagens no final) vale frisar que não precisa fazer sentido(portanto palavras como RLCF podem gerar pontos!)
- Para cada 2 letras, gera 1 ponto
- Uma vez que a letra foi escolhida no caça palavras, ela não pode ser escolhida novamente até encerrar aquela palavra

O Menu:

Antes das opções, deve estar mostrando o caça palavras, Menu:

1 – Tentar uma palavra: simplesmente peça uma palavra, e então faça a busca no caça palavras e diga quantos pontos foram gerados e então, adicione essa pontuação no jogador que esta jogando. (caso o jogador insira a mesma palavra, não faça a busca e avise que a palavra ja foi inserida)
2 – Gerar um novo caça-palavras: Gere um novo caça palavras. (resete todas as palavras até então inseridas)
3 – Encerrar Programa : Encerre o programa e agradeça
