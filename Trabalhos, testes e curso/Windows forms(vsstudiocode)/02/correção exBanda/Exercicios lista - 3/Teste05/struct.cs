namespace FazendaGado{

struct DataNascimento
{
    public int Mes;
    public int Ano;
}

struct Gado
{
    public int Codigo;
    public double LeiteSemanal;
    public double AlimentoSemanal;
    public DataNascimento Nasc;
    public char Abate; // S ou N
}
}