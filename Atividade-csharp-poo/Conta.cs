namespace ClassesObjetos
{
    public class Conta
    {
        public decimal Saldo = 0;

        public void Depositar(decimal valor)
        {
            Saldo += valor; // Saldo = valor + Saldo;
            Console.WriteLine($"Saldo atualizado: {Saldo:C}");
        }
    }
}