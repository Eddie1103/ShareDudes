<?php
if (isset($_POST['password'])) {
    $plainPassword = $_POST['password'];
    $hashedPassword = hash('sha256', $plainPassword);
    $response = ['success' => true, 'hashedPassword' => $hashedPassword];
} else {
    $response = ['success' => false, 'message' => 'Passwort nicht übermittelt'];
}

header('Content-Type: application/json');
echo json_encode($response);
?>
