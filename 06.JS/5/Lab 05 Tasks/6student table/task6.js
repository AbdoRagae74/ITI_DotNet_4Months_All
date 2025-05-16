var id = 1;

function addNewStudent() {
  var name = document.getElementById('name').value;
  var age = document.getElementById('age').value;
  if (name && age) {
    if (studentExist(name, age)) {
      alert('Student added before');
      return;
    }
    var table = document.getElementById('table')
    var newRow = table.insertRow(table.rows.length);
    var cell1 =  newRow.insertCell(0);
    var cell2 = newRow.insertCell(1);
    var cell3 = newRow.insertCell(2);
    var cell4 = newRow.insertCell(3);
    cell1.innerHTML = (id++);
    cell2.innerHTML = (name);
    cell3.innerHTML = (age);
    cell4.innerHTML = ('<button class=delete-btn onclick="deleteStudent(this)">Delete</button>');
    document.getElementById('name').value = '';
    document.getElementById('age').value = '';
  } else {
    alert('Please enter valid values for name and age');
  }
}

function studentExist(name, age) {
  var table = document.getElementById('table');
  for (var i = 0; i < table.rows.length; i++) {
    var row = table.rows[i];
    if (row.cells[1].innerHTML === name && row.cells[2].innerHTML === age) {
      return true;
    }
  }
  return false;
}

function deleteStudent(button) {
  button.parentNode.parentNode.remove();
}
