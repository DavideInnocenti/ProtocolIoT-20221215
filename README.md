# Protocollo IoT - Silos
***
## Introduzione

Il Client è una simulazione di un silo, equipaggiato da 4 sensori virtuali, che spediscono dati randomici selezionati in un range semi-realistico per il tipo di dato il sensore potrebbe rilevare sul campo:
- Sensore di livello  
- Sensore di pH
- Sensore di temperatura
- Sensore di pressione

Il Client è equipaggiato anche del pacchetto NuGet "**MQTTnet**", per poter rendere possibile l'utilizzo di MQTT. Il client pubblica sul topic **amaro2022test/innocentimartecchinifior/** (testato in ascolto in MQTT.fx at **amaro2022test/innocentimartecchinifior/#**) a intervallo di un solo secondo finché rimane attivo.

***

## Sicurezza

Sebbene la parte di sicurezza non sia stata integrata all'interno del progetto, si è fatto un pensiero a quale misure sarebbero utili da intraprendere fosse necessario.
Da subito, anche in piccolo numero, avere *credenziali di accesso* e relegare un *silo* nel **proprio topic** a svolgere le sue azioni (PUBLISH) tramite autorizzazione è necessario per **mantenere ordine** in ciò che viene pubblicato ed ***evitare che informazioni possano essere modificate in maniera errorea o maliziosa.*** Se poi il numero di silo dovesse anche aumentare, come mossa preliminare si può pensare a modificare anche il valore QoS, per aumentare le prestazioni del broker.
Particolarmente in ambito aziendale sarebbe anche buona norma *utilizzare una rete prottetta* e **preferibilmente interna** se possibile, per lo scambio dei dati da silo(s) a cloud.
