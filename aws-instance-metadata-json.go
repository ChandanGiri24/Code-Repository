package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
	"os"
	"encoding/json"
)


func main() {
	GetMetaDataJson()
}

func GetMetaDataJson() {
	url := "http://169.254.169.254/latest/"
	routes := []string{"meta-data/"}
	var responseJson interface{}
	for _, val := range routes {
		url = url + val
		response,err :=http.Get(fullUrl)
		if err != nil {
			fmt.Print(err.Error())
			os.Exit(1)
		}
		responseData, err := ioutil.ReadAll(response.Body)
		if err != nil {
			log.Fatal(err)
		}
		json.Unmarshal(body, &responseJson)
		}
}
