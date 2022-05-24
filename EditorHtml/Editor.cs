
using System.Text;

namespace EditorHtml
{
  public static class Editor

  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("ESC - PARA SAIR");
      Console.WriteLine("--------------------");
      Start();
    }


    public static void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-------------------------");
        Console.WriteLine("  Deseja salvar o arquivo? ");
        Console.WriteLine(" S = sim! // N = não!");
        Viewer.Show(file.ToString());

       char resposta = char.Parse(Console.ReadLine().ToLower());

       Console.WriteLine(resposta);
       

        if (resposta == 's')
        Save(file);
        
          

        if (resposta == 'n')
        Menu.Show();
       
         
    }

    public static void Save(StringBuilder file)
    {
      Console.Clear();
      Console.WriteLine(" Digite o caminho onde deseja salvar o arquivo: ");

      var path = Console.ReadLine();

      using (var savedFile = new StreamWriter(path))
      {
        savedFile.Write(file);
      }

      Console.WriteLine($"Arquivo {path} salvo com sucesso!");
      Console.ReadLine();

      Menu.Show();
      
    }
    

     
  }
}