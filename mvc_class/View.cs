@model HelloWorldMvcApp.Room
@{  /* optional for alternate version */
var room = ViewData.Model;
}

<body>
<div class="container">
<div class="col-md-6 col-md-offset-3">
<h1>Hello Stranger</h1>

<button type="button" class="btn btn-success submit">Ask</button>
<p>
Room Width: @room.Width Height: @room.Height
</p>
<div>
@foreach (var mo in room.Mobs)
{
<p>@mo</p>
}
/* <p>@Model.Width</p>   alternate version */
</div>
<br/><br/>
<div class="alert alert-warning fade">
<img src="http://entechprod.blob.core.windows.net/dotnetfiddle/morpheus.jpg" style="max-width:100%;"/><br/><br/>
<strong><span class="alert-content"></span></strong>
</div>
</div>
</div>
</body>
