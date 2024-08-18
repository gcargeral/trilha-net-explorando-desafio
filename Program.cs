using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Console.WriteLine("Suite 1:");
try{
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():F2} para {reserva.DiasReservados} dias.");
} catch (Exception ex) {
    Console.WriteLine($"Sinto muito, {ex.Message}");
}

// Cria a suíte
Suite suite2 = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 40);
Console.WriteLine("Suite 2:");
try{
// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite2);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():F2} para {reserva.DiasReservados} dias.");
} catch (Exception ex) {
    Console.WriteLine($"Sinto muito, {ex.Message}");
}
// Cria a suíte
Suite suite3 = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 50);

Console.WriteLine("Suite 3:");
try{
// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite3);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():F2} para {reserva.DiasReservados} dias.");
} catch (Exception ex) {
    Console.WriteLine($"Sinto muito, {ex.Message}");
}

