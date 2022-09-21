using (var ctx = new Context())
{
    var clientes = ctx.Clientes.ToList();

    foreach (var item in clientes)
    {
        Console.WriteLine($"Código: {item.Id} - Nome: {item.Nome}");
    }
}