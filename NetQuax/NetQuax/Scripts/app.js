
$(document).ready(function () {
  $('.dropdown-toggle').dropdown()
});

function ValidateAddUser() {

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
  if (errorMessage != "") {
    $(errorPanel).css("border", "1px solid red");
    $(errorPanel).text(errorMessage);
  }
}
function searchMovies() {
  var searchString = $('#searchVal').val();

}

function ShowBillingInfo(element) {
    if ($(element).val() > 1) {
        $('#billingInfoRow').fadeIn(200);
    }
    if ($(element).val() == 1){
        $('#billingInfoRow').fadeOut(200);
    }
}

function ValidateSignIn() {
  var errorMessage = "";
  var username = $('#signIn-Username').val();
  var password = $('#signIn-Password').val();

  if (username === "" || password === "") {
    errorFlag = true;
    errorMessage = "Both fields must be filled out";
  }
  var errorPanel = $('#signIn-Error');
  showErrorMessage(errorMessage, errorPanel);
}

function HandleSignIn(e) {
  alert("Handel");
  alert(e.ErrorMessage);
  if (e.Valid == true) {
    $('#modal-AddUser').modal('hide');
    location.reload();
  }
}

function showSignInModal(user) {
  if (!user) {
    $('#modal-SignIn').modal('show');
  }
}
function showCreateAccountModal(user) {
  if (!user) {
    $('#modal-AddUser').modal('show');
  }
}

function showDetailModal(id) {
  alert("showing modal");
  $('#modal-movieDetails-' + id).modal('show');
}

function ValidateSearchString() {
  var searchString = $('#searchString').val();
  var errorFlag = false;
  if (searchString == "") {
    alert("enter a value to search by");
    errorFlag = true;
  }
  return !errorFlag;
}

function HandleSearchJson(e) {
  alert(e.Html);
  $('#myMainBody').fadeOut(200, function () {
    this.innerHTML = e.Html;
  });
  $('#myMainBody').fadeIn(200)
}