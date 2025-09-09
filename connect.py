from azure.cosmos import CosmosClient, exceptions

# Replace with your actual values
endpoint = "https://cosmos-dev-k4vzvmdkaowv4.documents.azure.com:443/"
key = "2a6zMCYLNLeRZzURCXVdHVZCZoL4k5R4QU3Lz8qqQgTB6uAtR8pIImn5f9pQ6DhofSbiLVhgqYvoACDbY123g==;"

# Initialize the Cosmos client
client = CosmosClient(endpoint, key)

# Access a specific database and container
database_name = "SampleDB"
container_name = "SampleContainer"

try:
    database = client.get_database_client(database_name)
    container = database.get_container_client(container_name)
    print("Connected to container:", container_name)
except exceptions.CosmosHttpResponseError as e:
    print("Failed to connect:", e.message)
