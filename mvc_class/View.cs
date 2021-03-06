@model HelloWorldMvcApp.SampleViewModel
@{
	Layout = null;
}

<!DOCTYPE html>
<!-- template from http://getbootstrap.com/getting-started -->

<html lang="en">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>Bootstrap 101 Template</title>

		<!-- CSS Includes -->
		<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
		
		<style type="text/css">

			.field-validation-error {
				color: #ff0000;
			}
			
			td {
				height: 20px;
				width: 20px;
			}

		</style>
	</head>
	
	<body>
		<div class="container">
			<div class="col-md-6 col-md-offset-3">
				<h1>Hello Stranger</h1>
	
				@using (Html.BeginForm())
				{
					<div class="form-group">
						@Html.LabelFor(m => m.Question)
						@Html.TextBoxFor(model => model.Question, new {@class="form-control"}) 
						@Html.ValidationMessageFor(model => model.Question)
					</div>
				<p>@Model.Test</p> <!-- Displays Information -->
				<table>
					@for(int i = 0; i < 20; i++)
					{
					@:<tr>
						for(int j = 0; j < 20; j++)
						{
					@:<td>a </td>
						}
					@:</tr>
					}
				</table>
				
					<button type="button" class="btn btn-success submit">Ask</button>
				}
	
				<br/><br/>
				<div class="alert alert-warning fade">
					<img src="http://entechprod.blob.core.windows.net/dotnetfiddle/morpheus.jpg" style="max-width:100%;"/><br/><br/>
					<strong><span class="alert-content"></span></strong>
				</div>
			</div>
		</div>

		<!-- JS includes -->
		<script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
		<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>
	
		<script src="//ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js"></script>
		<script src="//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js"></script>
		
		<script type="text/javascript">
		
			function openAlert(txt) {
				$('.alert-content').text(txt);
				$('.alert').addClass('in');
			}
		
			function closeAlert() {
				$('.alert').removeClass('in');
			}
		
			$(function(){
				var answer = '@Model.Answer';
		
				if(answer && answer != '') 
					openAlert(answer);
		
				$('#Question').change(closeAlert);
				$('#Question').keyup(closeAlert);
		
				$('.submit').click(function(){
					if($('form').valid()) {
					
						$.ajax({
							url: '@Url.RouteUrl(new{ action="GetAnswer", controller="Home"})',
							data: {Answer: '', Question: $('#Question').val()},
								type: 'POST',
								dataType: 'json',
								contentType: "application/json; charset=utf-8",
								success: function(resp) {
								openAlert(resp);
						}});
					}
					else {
						closeAlert();
					}
				});
			
			});

		</script>
	</body>
</html>
