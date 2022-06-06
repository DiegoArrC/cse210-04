namespace program{
    public class scorekeeper {
int score = 0;


    private void addScore() {
        score += 100;
    }
    private void loseScore() {
        score -= 100;
    }
    public bool overlap(int player_x,/*int player_rx, int obj_lx,*/int obj_x, int obj_y) {
        if (obj_x > player_x && obj_x < (player_x+5) && obj_y < 10) {
            return true;
        }
        else {
            return false;
        }
    }
    }
}