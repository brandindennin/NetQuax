
function PostingForm() {
  alert("Posting form function: form submitted!");
}

function PostingComplete(e)
{
  $('#username').fadeOut(500, function () {
    $('#username').html('<p>Hello, ' + e.Name + '</p>');
    $('#username').fadeIn(500);
  });

  //$('#username').text("Hello, " + e.Name);
}