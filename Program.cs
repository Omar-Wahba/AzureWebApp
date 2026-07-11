var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Content("""
<!DOCTYPE html>
<html>
<head>
<title>Azure Demo</title>
<style>
body{
font-family:Arial;
text-align:center;
margin-top:100px;
background:#f5f5f5;
}
.card{
background:white;
width:500px;
margin:auto;
padding:30px;
border-radius:10px;
box-shadow:0 0 10px gray;
}
</style>
</head>
<body>
<div class="card">
<h1>Hello Azure!</h1>
<h2>My first Azure App Service</h2>
<p>This website is deployed from GitHub.</p>
<p>Current time:</p>
<h3>""" + DateTime.Now + """</h3>
</div>
</body>
</html>
""", "text/html");
});

app.Run();
