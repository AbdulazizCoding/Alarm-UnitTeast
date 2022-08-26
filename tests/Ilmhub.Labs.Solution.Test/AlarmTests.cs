namespace Ilmhub.Labs.Solution.Test;

public class AlarmTests
{
    [Theory]
    [InlineData(1, 30, 0, 45)]

    public void AlarmReturnTheTime45MinutsAgo(int inHour, int inMin, int outHour, int outMin)
    {
        var project = new Program();

        var result = project.StartAlarm(inHour, inMin);

        Assert.Equal(result.Item1, outHour);
        Assert.Equal(result.Item2, outMin);
    }
}