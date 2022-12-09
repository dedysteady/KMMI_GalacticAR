<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unityaccess');

    //Check connection
    if(mysqli_connect_errno())
    {
        echo "1: Connection Failed"; //error code #1 = connection failed
        exit();
    }

    $username = $_POST["name"];
    $password = $_POST["password"];

    //Check if name exists
    $namecheckquery = "SELECT username, salt, hash, score FROM players WHERE username='" . $username . "';";
    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name Check Query Failed");
    
    if (mysqli_num_rows($namecheck) != 1)
    {
        echo "5: No User / User more than one";
        exit();
    }

    //get login info from query
    $existinginfo = mysqli_fetch_assoc($namecheck);
    $salt = $existinginfo["salt"];
    $hash = $existinginfo["hash"];

    $loginhash = crypt($password, $salt);
    if ($hash != $loginhash)
    {
        echo "6: Incorrect Password"; //error code #6 - password does not hash
        exit();
    }

    echo "0\t" . $existinginfo["score"];
?>