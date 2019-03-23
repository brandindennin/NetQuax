namespace TestApplication.Models
{
  public class ExampleModel
  {
    private int[] _array;
    private string _title1;
    private string _title2;
    private string _title3;

    public ExampleModel() : base()
    {
      _title1 = null ;
      _title2 = null;
      _title3 = null;
      _array = null;
    }

    public int[] Array
    {
      get
      {
        int[] temp = new int[] { 1, 2, 4, 5, 11 };
        return temp;
      }
    }

    public string Title1
    {
      get
      {
        return "A New Hope";
      }
    }

    public string Title2
    {
      get
      {
        return "Empire Strike Back";
      }
    }

    public string Title3
    {
      get
      {
        return "Retrurn of the Jedi";
      }
    }
  }
}