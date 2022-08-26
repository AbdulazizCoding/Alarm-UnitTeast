public class Program
{
    public (int,int) StartAlarm(int InOcl, int InMin)
    {
        if(InOcl == 0 && InMin < 45)
        {
            InOcl = 23;
            InMin -= 45;

            return (InOcl, 60 + InMin);
        }if(InMin < 45)
        {
            InOcl -= 1;
            InMin = 45 - InMin;
        }
        return (InOcl, 60 - InMin);
    }
}
