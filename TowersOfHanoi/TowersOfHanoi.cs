using System;
using System.Collections.Generic;
using System.Linq;

public static class MoveCalculator
{         
    private static void Calculate(int n, int fromPole, int toPole)
    {
        if (n == -1)
        {
            return; // We are done
        }
        int intermediatePole = GetIntermediatePole(fromPole, toPole);
        
        Calculate(n - 1, fromPole, intermediatePole);
        moves.Add(new Move(fromPole, toPole));
        Calculate(n - 1, intermediatePole, toPole);
    }   
} 
    public class Move 
{
    public Pole FromPole { get; set; }
    public Pole ToPole { get; set; }
    
    public bool AffectCount()
    {
        //If the poles don't change the move should not be counted
        if (ToPole.Equals(FromPole))
        {
            return false;
        }
        return IsValid();
    }            

    public bool IsValid()
    {
        //Allow a move where the pole dont change
        if (ToPole.Equals(FromPole))
        {
            return true;
        }
        return ToPole.AllowDisk(FromPole.getTopDisk());
    }    
    
}   
public class Disk : PictureBox
{
    public int Number { get; set; }

    public Disk(int Number) : base()
    { ... }

    public void MoveToPole(Pole DestinationPole)
    { ... } 
}

public class Pole : PictureBox
{
    public SortedList<int, Disk> Disks { get; set; }
    public int Number { get; set; }

    public Pole(int number)
    { 
    ...    
    }

    public bool IsEmpty()
    {
        return Disks.Count == 0;
    }

    public bool AllowDisk(Disk disk)
    {
        if (disk == null)
        {
            return false;
        }
        if (Disks.Count == 0)
        {
            return true;
        }
        return getTopDisk().Number > disk.Number;
    }
 
    public Disk getTopDisk()
    {
        if (Disks.Count > 0)
        {
            return Disks.First().Value;
        }
        return null;
    }

    public void RemoveDisk()
    {
        Disks.Remove(Disks.First().Key);
    }

    public void AddDisk(Disk disk)
    {

        if (AllowDisk(disk))
        {
            disk.MoveToPole(this);
            Disks.Add(disk.Number, disk);
        }
    }
    ...
}
public static class GameState
    {
        public static List<Pole> Poles = new List<Pole>();
        public static List<Bitmap> ImageList = new List<Bitmap>();
        public static int MoveCount { get; set; }
        public static int NumberOfDisks { get; set; }
        
        // Start the game
        static GameState()
        {
            LoadImagesFromFile();
            RestartGame(3);
        }
 
        public static int Move(Move move)
        {
         if (move.AffectCount())
            {
                MoveCount++;
            }
            
            if (move.IsValid())
            {
                Disk disk = move.FromPole.getTopDisk();
                Poles[move.FromPole.Number].RemoveDisk();
                Poles[move.ToPole.Number].AddDisk(disk);
                return MoveCount;
            }
 
            else //Invalid move
            {
                return -1;
            }  
        }
 
        public static bool IsSolved()
        {
            return (Poles[Properties.Settings.Default.EndPole].Disks.Count == NumberOfDisks);
        } 
}
[TestClass()]
public class MoveCalculatorTest {
    ...
    [TestMethod()]
    public void GetMoveCountTest()
    {
        int actualMoveCount = MoveCalculator.GetMoveCount(3);
        int expectedMoveCount = 7;
        Assert.AreEqual(expectedMoveCount, actualMoveCount);

        actualMoveCount = MoveCalculator.GetMoveCount(4);
        expectedMoveCount = 15;
        Assert.AreEqual(expectedMoveCount, actualMoveCount);

        actualMoveCount = MoveCalculator.GetMoveCount(5);
        expectedMoveCount = 31;
        Assert.AreEqual(expectedMoveCount, actualMoveCount);
    }  
}

[TestClass()] 
public class GameStateTest  {
...
    [TestMethod()]
    public void IsSolvedTest()
    {
        GameState.RestartGame(numberOfDisks);

        bool expectedBefore = false; 
        bool actualBefore = GameState.IsSolved();
        solveGame();
        bool expectedAfter = true;
        bool actualAfter = GameState.IsSolved();

        //Assert 
        Assert.AreEqual(expectedBefore, actualBefore);
        Assert.AreEqual(expectedAfter, actualAfter);
    }
}