import { Game, Player } from "@/app"

function constructScoreString(player1, score1, player2, score2) {
  return `${player1}: ${score1} \n${player2}: ${score2}`
}

describe('Game', () => {
  it('should exist', () => {
    expect(new Game()).not.toBeNull
  });

  it('should have two players', () => {
    const game = new Game();
    expect(game.player1).not.toBeNull;
    expect(game.player2).not.toBeNull;
  })

  it('should have an initial score of love : love', () => {
    const game = new Game();
    const expectedScoreString = constructScoreString("Unknown player", "love", "Unknown player", "love")
    expect(game.score).toBe(expectedScoreString);
  })

  it('should reflect player names in the score', () => {
    const game = new Game("Alice", "Bob");
    const expectedScoreString = constructScoreString("Alice", "love", "Bob", "love")
    expect(game.score).toBe(expectedScoreString);
  })
});

describe('Player', () => {
  it('should exist', () => {
    expect(new Player('Test name')).not.toBeNull
  });

  it('should have a name', () => {
    const player = new Player('Test name');
    expect(player.name).not.toBeNull;
  });
});

// this time, let's go OO