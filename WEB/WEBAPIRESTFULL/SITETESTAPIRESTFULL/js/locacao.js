	var livrosList;
	var usuariosList;	

	jQuery(document).ready(function(){
		var settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Livros",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}
	
			$.ajax(settings).done(function (response) {
				livrosList = response;
	
				$.each(response,function(index,value){
					$('#Livro')[0].innerHTML += '<option value=\''+ value.Id +'\'>'+ value.Titulo +'</option>';
				});
			});
	
			settings = {
			"async": true,
			"crossDomain": true,
			"url": "http://localhost:59271/Api/Usuarios",
			"method": "GET",
			"headers": {
				"Content-Type": "application/json",
				"Accept": "*/*"
			  }
			}
		
			$.ajax(settings).done(function (response) {
				usuariosList = response;
	
				$.each(response,function(index,value){
					$('#Usuario')[0].innerHTML += '<option value=\''+ value.Id +'\'>'+ value.Nome +'</option>';
				});

				GetMethod(null);
			});
				
	});

    function GetMethod(object){
			var settings = {
				"async": true,
				"crossDomain": true,
				"url": "http://localhost:59271/Api/Locacao",
				"method": "GET",
				"headers": {
					"Content-Type": "application/json",
					"Accept": "*/*"
				  }
				}

				$.ajax(settings).done(function (response) {
				  RefreshGrid(response);
				});
			
			return false;
	}
	
	  
	function translateField(filedValue,listTrasnlate,toValue){
		var retorno;
   
	   $.each(listTrasnlate,function(index,value){
		   if(value.Id == filedValue)
		   retorno = value[toValue];
	   });
   
	   return retorno;
   }
   
    function RefreshGrid(contentValue){
	   $('#tDataGrid').empty();
	   $('#tDataGrid').html(  '<tbody>'
							+ 	'<tr>'
							+ 		'<th>ID</th>'
							+ 		'<th>Livro</th>'
							+ 		'<th>Usuario</th>' 	
							+ 		'<th>Tipo</th>' 	
							+ 		'<th>Devolucao</th>' 		
							+ 		'<th>Ativo</th>'
							+ 		'<th>Opções</th>'
							+ 	'</tr>'
							+ '</tbody>');

		$.each(contentValue,function(index,value) {
        var row =     '<tr>'
						+ '<td>' + value.Id        + '</td>'
						+ '<td>' + translateField(value.Livro,livrosList,'Titulo')     + '</td>'
						+ '<td>' + translateField(value.Usuario,usuariosList,'Nome')  + '</td>'		
						+ '<td>' + value.Tipo + '</td>'	
						+ '<td>' + value.Devolucao + '</td>'					
						+ '<td>' + value.Ativo     + '</td>'
						+ '<td>' 
						+ 	'<div    class=\'col-md-12\' style=\'float: right;\'>'
						+ 		'<div    class=\'col-md-6\'>'
						+ 			'<button class=\'btn btn-block btn-danger col-md-3 btn-delet-event\' type=\'button\' send-post=\'Locacao\' value=\''+ value.Id +'\'>Remover</button>'
						+ 		'</div>'
						+ 		'<div     class=\'col-md-6\'>'
						+ 			'<button  class=\'btn btn-block btn-success col-md-3 btn-editing-event\' send-post=\'Locacao\' value=\''+ value.Id + '\' type=\'button\' \>Editar</button>'
						+ 		'</div>'
						+ 	'</div>'
						+ '</td>'
					+ '</tr>';
        $('#tDataGrid').append(row);
		});

		SetGridClickEvents();
    }
	
	
  
  