using Pr_1_class;

var Music = new Music("The milion masks of god", "Manchester Orchestra", 2021, 11, 200);

Music.DisplayInfo();

Music.UpdateCopys(285);
if(Music.NeedMore() )
{
    Console.WriteLine("Yes, need more");
    Music.EndSales();
}
else
{
    Console.WriteLine("No, need more not");
}

Music.UpdateCopys(302);
if (Music.NeedMore())
{
    Console.WriteLine("Yes, need more");
    Music.EndSales();
}
else
{
    Console.WriteLine("No, need more not");
}