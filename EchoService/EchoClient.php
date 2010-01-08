<?php
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