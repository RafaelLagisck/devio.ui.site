
var builder = WebApplication.CreateBuilder(args);


// Adicionar MVC antigo add.MVC()
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();


app.MapAreaControllerRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
app.MapAreaControllerRoute("AreaVendas", "Vendas", "Vendas/{controller=Pedidos}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

