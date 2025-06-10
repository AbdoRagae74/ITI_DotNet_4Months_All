<?php
$servername = "localhost"; // or your cPanel DB server
$username = "your_user";
$password = "your_pass";
$dbname = "your_db";

$conn = new mysqli($servername, $username, $password, $dbname);
if ($conn->connect_error) {
    die(json_encode([]));
}

$today = date('Y-m-d');

// Adjust table/column names if needed
$sql = "
    SELECT s.name, SUM(od.qty) AS total_qty
    FROM order_details od
    JOIN sandwiches s ON od.sandwich_id = s.id
    JOIN Orders o ON od.order_id = o.orderid
    WHERE DATE(o.orderdate) = ?
    GROUP BY od.sandwich_id
";

$stmt = $conn->prepare($sql);
$stmt->bind_param("s", $today);
$stmt->execute();
$result = $stmt->get_result();

$data = [];
while ($row = $result->fetch_assoc()) {
    $data[] = $row;
}

echo json_encode($data);
?>
