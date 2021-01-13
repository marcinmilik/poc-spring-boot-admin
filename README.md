1. cd DynamicLogTestService
2. docker build . -t dockerlogtestservice
3. cd ../SpringBootAdmin
4. docker build . -t admin-server
5. cd ..
6. kubectl apply -f .\dynamic-log-test-service.yaml
7. kubectl apply -f .\spring-boot-admin.yaml


If you'd like to call endpoint from dockerlogtestservice you can create role binding (do only for development purpose):
kubectl create clusterrolebinding cluster-system-anonymous --clusterrole=cluster-admin --user=system:anonymous

And call:
https://kubernetes.docker.internal:6443/api/v1/namespaces/default/services/mytest/proxy/weatherforecast