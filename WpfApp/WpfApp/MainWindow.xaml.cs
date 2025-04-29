using System.Windows;

namespace WpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CreateTask();   
    }

    void AddMessage(string message)
    {
        int CurrentThreadId = Thread.CurrentThread.ManagedThreadId;
        this.Dispatcher.Invoke(() =>
        {
            Messages.Content +=
                $"Mensaje: {message}," +
                $"Hilo actual: {CurrentThreadId}\n";
        });
  
    }

    void CreateTask()
    {
        Task T;
        // ¿Qué es un delegado? Apuntador a funciones.
        // Por ejemplo: Action y Func
        Action Code = new Action(ShowMesage);
        T = new Task(Code);
        Task T2 = new Task(delegate
        {
            MessageBox.Show("Ejecutando una tarea en un método anónimo.");
        });
        Task T3A = new Task(ShowMesage);
        Task T3 = new Task(
     () => ShowMesage());

        // Expresión Lambda:
        // (parámetros de entrada) => Expresión
        // () => Expresión
        // El operador lambda (=>) se lee como "va hacia"

        Task T4 = new Task(() => MessageBox.Show("Ejecutando la tarea 4"));

        Task T5 = new Task(() =>
        {
            DateTime CurrentDate = DateTime.Today;
            DateTime StartDate = CurrentDate.AddDays(30);
            MessageBox.Show($"Tarea 5. Fecha calculada: {StartDate}");
        });

        Task T6 = new Task((message) =>
            MessageBox.Show(message.ToString()), "Expresión lambda con parámetros.");

        Task T7 = new Task(() => AddMessage("Ejecutando la tarea"));
        T7.Start();
        AddMessage("En el hilo principal");

        // TaskFactory
    }

    void ShowMesage()
    {
        MessageBox.Show("Ejecutando el método ShowMessage");
    }
}

