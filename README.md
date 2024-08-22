# Atividade de Detalhar data e Desconto do INSS

```csharp
Console.Write("Digite uma data: ");
DateTime data = DateTime.Parse(Console.ReadLine());

string semana = string.Format($"\nSemana: { data.ToString(@"dddd", new CultureInfo("PT-pt")) }");
Console.WriteLine(semana);
```
**strings**
- DateTime = String de data.
- Double = String númerica com decimal

# Comandos

```csharp
new CultureInfo("PT-pt")
```
Traduz para português.

```csharp
data.ToString(@"dddd",
```
Converte uma string, no caso, a string "data" é numérica, e converte para "@dddd" que é para o dia da semana.
