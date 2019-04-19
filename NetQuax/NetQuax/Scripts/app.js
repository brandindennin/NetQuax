
$(document).ready(function () {
  $('.dropdown-toggle').dropdown()
});

function ValidateAddUser() {
  alert('test');
  var errorMessage = "";
  var errorFlag = false;
  var errorPanel = $('#addUser-Error');
  var userName = $('#addUser-Username').val();
  if (userName === "") {
    errorFlag = true;
    errorMessage = "Username is required";
  }
  var password = $('#addUser-Password').val();
  if (password === "") {
    errorFlag = true;
    errorMessage = "password is required";
  }

  var passwordConfirmation = $('#addUser-PasswordConfirmation').val();

  if (passwordConfirmation !== password) {
    errorFlag = true;
    errorMessage = "confirmation does not match";
  }

  if (errorMessage.length > 0) {
    showErrorMessage(errorMessage, errorPanel);
  }
  return errorFlag;
}

function showErrorMessage(errorMessage, errorPanel) {
  alert('error');
  $(errorPanel).css("border", "1px solid red");
  $(errorPanel).text(errorMessage);
}

function ShowBillingInfo(element) {
  if ($(element).val() > 1) {   
    $('#billingInfoRow').fadeIn(200);
  }
}