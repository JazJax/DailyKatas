namespace MarsRover.Tests;

public class RoverShould
{
    [Fact]
    public void ReceiveCommandsAsAnArray()
    {
        RoverApi rover = new RoverApi();
        char[] commands = {'f','b'};
        rover.Command(commands);
    }

    [Fact]
    public void ActOnEachCommandInTurn()
    {
        RoverApi rover = new RoverApi();
        char[] commands = {'f','f'};
        (int, int) initialPosition = (0,0);
        (int, int) finalPosition = (2,0);

        Assert.Equal(initialPosition, rover.GetPosition());

        rover.Command(commands);        
        Assert.Equal(finalPosition, rover.GetPosition());
    }

    [Fact]
    public void HaveAPosition()
    {
        RoverApi rover = new RoverApi();
        (int,int) expectedPosition = (0,0);
        (int, int) result = rover.GetPosition();
        Assert.Equal(result, expectedPosition);
    }

    [Fact]
    public void HaveADirection()
    {
        RoverApi rover = new RoverApi();
        char expectedDirection = 'N';
        char result = rover.GetDirection();
        Assert.Equal(result, expectedDirection);
    }

    [Fact]
    public void MoveForwards()
    {
        RoverApi rover = new RoverApi();
        (int, int) initialPosition = (0,0);
        (int, int) finalPosition = (1,0);

        (int,int) result1 = rover.GetPosition();
        Assert.Equal(initialPosition, result1);

        rover.Command(['f']);
        (int,int) result2 = rover.GetPosition();
        Assert.Equal(finalPosition, result2);
    }

    [Fact]
    public void MoveBackwards()
    {
        RoverApi rover = new RoverApi();
        (int, int) initialPosition = (0,0);
        (int, int) finalPosition = (-1,0);

        (int,int) result1 = rover.GetPosition();
        Assert.Equal(initialPosition, result1);

        rover.Command(['b']);
        (int,int) result2 = rover.GetPosition();
        Assert.Equal(finalPosition, result2);
    }

    [Fact]
    public void TurnRight()
    {
        RoverApi rover = new RoverApi();

        char direction = rover.GetDirection();
        Assert.Equal('N', direction);
        
        rover.Command(['r']);
        rover.GetDirection();
        Assert.Equal('E', rover.GetDirection());

        rover.Command(['r']);
        rover.GetDirection();
        Assert.Equal('S', rover.GetDirection());

        rover.Command(['r']);
        rover.GetDirection();
        Assert.Equal('W', rover.GetDirection());

        rover.Command(['r']);
        rover.GetDirection();
        Assert.Equal('N', rover.GetDirection());
    }

    [Fact]
    public void TurnLeft()
    {
        RoverApi rover = new RoverApi();

        char direction = rover.GetDirection();
        Assert.Equal('N', direction);
        
        rover.Command(['l']);
        rover.GetDirection();
        Assert.Equal('W', rover.GetDirection());

        rover.Command(['l']);
        rover.GetDirection();
        Assert.Equal('S', rover.GetDirection());

        rover.Command(['l']);
        rover.GetDirection();
        Assert.Equal('E', rover.GetDirection());

        rover.Command(['l']);
        rover.GetDirection();
        Assert.Equal('N', rover.GetDirection());
    }
}