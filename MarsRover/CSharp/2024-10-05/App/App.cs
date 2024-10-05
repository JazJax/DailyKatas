/* - Develop an API that...
    -  translates the commands to rover instructions 

- You are given the initial starting point (x,y)
- and the direction (N,S,E,W) it is facing.

- The rover receives a character array of commands.
    - Implement commands that move the rover forward/backward (f,b).
    - Implement commands that turn the rover left/right (l,r).
    - Implement wrapping from one edge of the grid to another. (planets are spheres after all)

- Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the sequence and reports the obstacle.

## Rules
- Be careful about edge cases and exceptions. We can not afford to lose a mars rover, just because the developers overlooked a null pointer.
*/

//QUESTIONS: confirm stating position? Gonna pass in to the constructor to avoid magic strings

//Assunmpotions: North is increase (X,  ); East is increase (  , Y)

namespace MarsRover;

public class RoverApi
{
    private int north = 0;
    private int east = 0;
    private char direction { get; set; } = 'N';

    public void Command(char[] commands)
    {
        foreach (char command in commands)
        {
            var result = command switch
            {
                'f' => north++,
                'b' => north--,
                'r' => TurnRight(),
                'l' => TurnLeft(),
                _ => 0
            };
        }
    }

    public (int, int) GetPosition()
    {
        return (north, east);
    }

    public char GetDirection()
    {
        return direction;
    }

    private char TurnRight()
    {
        direction = direction switch
        {
            'N' => 'E',
            'E' => 'S',
            'S' => 'W',
            'W' => 'N'
        };

        return direction;
    }

    private char TurnLeft()
    {
        direction = direction switch
        {
            'N' => 'W',
            'W' => 'S',
            'S' => 'E',
            'E' => 'N'
        };

        return direction;
    }
}
