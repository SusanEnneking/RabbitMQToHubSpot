# RabbitMQ To Hubspot #
When your team is faced with a situation where you are no longer able to use MSMQ, RabbitMQ comes to the rescue!

For this project, I'm using VSCode and Docker Compose running on a Mac.

## Parts ##
1. RabbitMQ running in Docker Container
2. HubSpot Intance -- [Create a HubSpot developer account](https://developers.hubspot.com/get-started)
3. Create a Hubspot Integration
4. The original purpose for this code was to allow an external ERP system hosted on Windows to add Companies and Contacts to HubSpot via RabbitMQ messages.  This implementation won't use Windows at all, so I'll do a bit of investigation to understand the best way to share this message definition. 

## To Run ##

```docker-compose up -d ``` To start RabbitMQ

Navigate to http://localhost:15672
