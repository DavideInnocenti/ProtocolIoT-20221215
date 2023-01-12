# Protocollo IoT - Silos

Il Client è una simulazione di un silo, equipaggiato da 4 sensori virtuali, che spediscono dati randomici selezionati in un range semi-realistico per il tipo di dato il sensore potrebbe rilevare sul campo:
- Sensore di livello  
- Sensore di pH
- Sensore di temperatura
- Sensore di pressione

Il Client è equipaggiato anche del pacchetto NuGet "**MQTTnet**", per poter rendere possibile l'utilizzo di MQTT. Il client pubblica sul topic **amaro2022test/innocentimartecchinifior/** (testato in ascolto in MQTT.fx at **amaro2022test/innocentimartecchinifior/#**) a intervallo di un solo secondo finché rimane attivo.
