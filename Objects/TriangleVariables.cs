namespace Triangle.Objects
{
  public class TriangleSides
  {
    private int _side1;
    private int _side2;
    private int _side3;


    public int GetSide1()
    {
      return _side1;
    }
    public void SetSide1(int newSide1)
    {
      _side1 = newSide1;
    }
    public int GetSide2()
    {
      return _side2;
    }
    public void SetSide2(int newSide2)
    {
      _side2 = newSide2;
    }
    public int GetSide3()
    {
      return _side3;
    }
    public void SetSide3(int newSide3)
    {
      _side3 = newSide3;
    }

    public int GetTriangleType()
    {
      if(_side1 == _side2)
      {
        return _side1;
      }
      else
      {
        return _side2;
      }
    }
  }
}
