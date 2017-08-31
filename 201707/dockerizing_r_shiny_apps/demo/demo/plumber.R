# plumber.R

#* @get /mean
normalMean <- function(samples = 10) {
    data <- rnorm(samples)
    mean(data)
}

#* @post /sum
addTwo <- function(a, b) {
    as.numeric(a) + as.numeric(b)
}

#* @get /mtcars
cars <- function(samples = 2) {
    toJSON(head(mtcars, samples))
}

#usage
#library(plumber)
#r <- plumb("plumber.R") # Where 'plumber.R' is the location of the file shown above
#r$run(port = 8000)