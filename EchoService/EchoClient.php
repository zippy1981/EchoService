<?php
trigger_error('Test notice', E_USER_NOTICE);
trigger_error('Test warning', E_USER_WARNING);

$client = new SoapClient
	('http://localhost:8731/EchoService/?wsdl',
	 array(
		'location' => 'http://localhost:8731/EchoService/Basic',
		'trace' => true,
		'soap_version' => SOAP_1_1,
		'connection_timeout' => 5
	)
);

echo $client->echo(array('request' => "Hello World"))->EchoResult;
?>