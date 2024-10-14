class Game {
    player1: Player;
    player2: Player;
    score: String = this.getScore();

    constructor(player1: String = 'Unknown player', player2: String = 'Unknown player') {
        this.player1 = new Player(player1);
        this.player2 = new Player(player2);
        // this.score = "Player 1: love \nPlayer 2: love";
    }

    getScore() {
        const myPlayer1 = this.player1;
        return `${this.player1.name}: ${this.player1.score} \n${this.player2.name}: ${this.player2.score}`;
    }
}

class Player {
    name: String;
    score: String = "love";

    constructor(playerName: String) {
        this.name = playerName;
    }
}

export {Game, Player}