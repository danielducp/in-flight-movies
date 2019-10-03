public class Movie
{
    private string filmname;
    private int duration1;
    private int duration2;

    public Movie(string filmname,int duration1)
    {
        this.filmname=filmname;
        this.duration1=duration1;
        
    }

    public int FilmsDurations(){
        return (this.duration1+this.duration2);
    }
}