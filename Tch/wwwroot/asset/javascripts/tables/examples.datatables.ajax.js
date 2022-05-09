/*
Name: 			Tables / Ajax - Examples
Written by: 	Okler Themes - (http://www.okler.net)
Theme Version: 	1.5.5
*/

(function($) {

	'use strict';

	var datatableInit = function() {

		var $table = $('#datatable-ajax');
		$table.dataTable({
			bProcessing: true,
			sAjaxSource: $table.data('url')
		});

 $(".datatable-ajax").each(function(){
		var $tableA = $(this);
		$tableA.dataTable({
			bProcessing: true,
			sAjaxSource: $tableA.data('url')
		});
  } );




	};
	
	

  	
	
	

	$(function() {
		datatableInit();
	});

}).apply(this, [jQuery]);