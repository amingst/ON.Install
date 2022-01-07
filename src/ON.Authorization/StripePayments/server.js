const grpc = require('@grpc/grpc-js')
const path = require('path')
const { v4: uuidv4 } = require('uuid')

const options = {
	keepCase: true,
	longs: String,
	enums: String,
	defaults: true,
	oneofs: true,
}

// TODO: Refactor
var protoLoader = require('@grpc/proto-loader')
const SUBSCRIPTION_PATH = './proto/Authorization/Subscription.proto'
var subscriptionDefinition = protoLoader.loadSync(SUBSCRIPTION_PATH, options)
var subscriptionProto = grpc.loadPackageDefinition(subscriptionDefinition)
var subscriptionService =
	subscriptionProto.ON.Fragments.Authorization.SubscriptionService

// Load Data
const subscriptions = require('./subscriptions')

const server = new grpc.Server()

server.addService(subscriptionService.service, {
	getAll: (_, callback) => {
		callback(null, { subscriptions })
	},
})

server.bindAsync(
	// TODO: Reference port in env
	'127.0.0.1:50051',
	grpc.ServerCredentials.createInsecure(),
	(error, port) => {
		if (error) console.error(error)
		console.log(`Server running at http://127.0.0.1:${port}`)
		server.start()
	}
)
