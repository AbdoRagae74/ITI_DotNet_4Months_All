namespace LINQR3DotNetMNFD02
{
    /*-------------------------------------------------------------------------*/
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
    /*-------------------------------------------------------------------------*/
    public class Male : User
    {

    }
    /*-------------------------------------------------------------------------*/
    public class Female : User
    {

    }
    /*-------------------------------------------------------------------------*/
}
