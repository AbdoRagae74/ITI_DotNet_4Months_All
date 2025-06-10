<?php
$servername = "localhost";     // or remote server
$username   = "db_user";
$password   = "db_pass";
$dbname     = "db_name";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$query = $_GET['query'] ?? '';

if (strtolower($query) === 'hello123') {
    // Return total of today's orders
    $today = date('Y-m-d');
    $stmt = $conn->prepare("SELECT SUM(price) AS total FROM orders WHERE DATE(orderdate) = ?");
    $stmt->bind_param("s", $today);
    $stmt->execute();
    $stmt->bind_result($total);
    $stmt->fetch();
    $stmt->close();

    echo "Total of today's orders: $" . number_format($total ?? 0, 2);

} elseif (is_numeric($query)) {
    // Return price for specific order ID
    $orderId = intval($query);
    $stmt = $conn->prepare("SELECT price FROM orders WHERE orderid = ?");
    $stmt->bind_param("i", $orderId);
    $stmt->execute();
    $stmt->bind_result($price);
    if ($stmt->fetch()) {
        echo "Order #$orderId total: $" . number_format($price, 2);
    } else {
        echo "Order #$orderId not found.";
    }
    $stmt->close();
} else {
    echo "Invalid input.";
}

$conn->close();
?>
