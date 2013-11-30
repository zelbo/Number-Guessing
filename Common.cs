namespace NumberGuessing
{
    public enum GameState { Initialize, Guess, Win, Lose, Exit }
    public enum Difficulty { Low = 1, Medium = 10, High = 100 }
    public enum Rating { Correct = 0, Close = 2, Off = 4, WayOff = 5 }

    public enum MyKeys
    {
        Escape, Enter,
        NumberKey_1, NumberKey_2, NumberKey_3, NumberKey_4, NumberKey_5,
        NumberKey_6, NumberKey_7, NumberKey_8, NumberKey_9, NumberKey_0,
        ArrowUp, ArrowDown, ArrowLeft, ArrowRight
    }

}
