public class Save

{
    public void SaveFile() {

        Write write = new Write();
        
        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();

        string  copyTxt = File.ReadAllText(write._fileName);
        Console.Out.WriteLine(copyTxt);

        File.WriteAllText(filename, copyTxt);
        
    }
    

}