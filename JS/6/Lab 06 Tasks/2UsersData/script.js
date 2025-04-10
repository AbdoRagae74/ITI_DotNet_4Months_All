function fetchUsers() {
  var xhr = new XMLHttpRequest();
  xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
  xhr.onload = function () {
    if (xhr.status === 200) {
      var users = JSON.parse(xhr.responseText);
      displayUsers(users);
    } else {
      console.error('Failed to fetch users');
    }
  };
  xhr.send();
}

function displayUsers(users) {
  var tbody = document.querySelector('#user-table tbody');
  tbody.innerHTML = '';

  for (var i = 0; i < users.length; i++) {
    var user = users[i];
    var row = document.createElement('tr');
    row.innerHTML = `
      <td>${user.id}</td>
      <td>${user.name}</td>
      <td>${user.email}</td>
      <td>
        <button onclick="showDetails(${user.id})">Details</button>
        <button onclick="deleteUser(${user.id})">Delete</button>
      </td>
    `;
    tbody.appendChild(row);
  }
}

function showDetails(userId) {
  var xhr = new XMLHttpRequest();
  xhr.open('GET', 'https://jsonplaceholder.typicode.com/users/' + userId, true);
  xhr.onload = function () {
    if (xhr.status === 200) {
      var user = JSON.parse(xhr.responseText);
      displayDetails(user);
    } else {
      console.error('Failed to fetch user details');
    }
  };
  xhr.send();
}

function displayDetails(user) {
  var detailsContainer = document.getElementById('details-container');
  detailsContainer.innerHTML = `
      <h2>User Details</h2>
      <p><strong>ID:</strong> ${user.id}</p>
      <p><strong>Name:</strong> ${user.name}</p>
      <p><strong>Email:</strong> ${user.email}</p>
      <p><strong>Username:</strong> ${user.username}</p>
      <p><strong>Phone:</strong> ${user.phone}</p>
      <p><strong>Website:</strong> ${user.website}</p>
      <p><strong>Address:</strong> ${user.address.street}, ${user.address.suite}, ${user.address.city}, ${user.address.zipcode}</p>
      <p><strong>Company:</strong> ${user.company.name}</p>
    `;
}

function deleteUser(userId) {
  var rows = document.querySelectorAll('#user-table tbody tr');
  for (var i = 0; i < rows.length; i++) {
    var rowUserId = rows[i].querySelector('td').innerText;
    if (rowUserId == userId) {
      rows[i].remove();
      break;
    }
  }

  var detailsContainer = document.getElementById('details-container');
  var detailsUserId = detailsContainer.querySelector('p strong')?.innerText;
  if (detailsUserId && detailsUserId == userId) {
    detailsContainer.innerHTML = '';
  }
}

fetchUsers();
