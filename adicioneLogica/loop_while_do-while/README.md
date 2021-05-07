# Adicione lógica de loop a seu código usando as instruções "do-while" e "while" em C#

## Desafio batalha em RPG

Na maioria das funções que desempenham jogos, o personagem do jogador batalha contra personagens não controlados por outros jogadores, que geralmente são monstros ou vilões. Normalmente, uma batalha consiste em cada personagem gerar um valor aleatório usando dados e esse valor é subtraído da pontuação de integridade do adversário. Quando a integridade de um personagem chega a zero, ele morre ou perde.

Neste desafio, vamos reduzir essa interação à sua essência. Um herói e um monstro começam com a mesma pontuação de integridade. Durante a rodada do herói, ele gerará um valor aleatório que será subtraído da integridade do monstro. Se a integridade do monstro for maior que zero, ela terá sua rodada e atacará o herói. Desde que tanto o herói quanto o monstro tenham integridade maior que zero, a batalha continuará.

### Regras do Jogo

- O herói e o monstro começarão com dez pontos de integridade.
- Todos os ataques serão um valor entre 1 e 10.
- O herói atacará primeiro.
- Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
- Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
- Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
- Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
- Imprima quem foi o vencedor.

Saída semelhante à desejada:


`Monster was damaged and lost 1 health and now has 9 health.`
`Hero was damaged and lost 1 health and now has 9 health.`
`Monster was damaged and lost 7 health and now has 2 health.`
`Hero was damaged and lost 6 health and now has 3 health.`
`Monster was damaged and lost 9 health and now has -7 health.`
`Hero wins!`
