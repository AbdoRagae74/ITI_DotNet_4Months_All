<?php
// header("Content-Type: application/json");
// DB config
$host = "srv655297.hstgr.cloud:2083";
$username = "abdoragae_abdoragae";
$password = "=fa;i6{qjvuP";
$database = "abdoragae_OrdersDB";

// Connect
$conn = new mysqli($host, $username, $password, $database);

// Check
if ($conn->connect_error) {
    http_response_code(500);
    echo json_encode(["error" => "Connection failed"]);
    exit;
}

// Query
$result = $conn->query("SELECT id, name, price FROM sandwiches");

$sandwiches = [];

while ($row = $result->fetch_assoc()) {
    $sandwiches[] = $row;
}

echo json_encode($sandwiches);

$conn->close();
