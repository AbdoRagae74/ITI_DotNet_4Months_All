<?php
// DB connection info
$host = "srv655297.hstgr.cloud:2083";
$username = "abdoragae_abdoragae";
$password = "=fa;i6{qjvuP";
$database = "abdoragae_OrdersDB";

// Connect
$conn = new mysqli($host, $username, $password, $database);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Example username (you can change this to use session or form data)
$usernameValue = "Guest"; // You can change this to $_POST['username'] if needed

$selectedSandwiches = $_POST['sandwiches'] ?? [];
if (empty($selectedSandwiches)) {
    die("No sandwiches selected.");
}



$conn->close();
?>
