
1. Prepare namespaces in k8

kubectl create namespace application-world

kubectl create namespace administration-world

2. cd DynamicLogTestService
3. docker build . -t dockerlogtestservice
4. cd ../SpringBootAdmin
5. docker build . -t admin-server
6. cd ..
7. kubectl apply -f .\dynamic-log-test-service.yaml
8. kubectl apply -f .\spring-boot-admin.yaml


If you'd like to call endpoint from dockerlogtestservice you can create role binding (do only for development purpose):
kubectl create clusterrolebinding cluster-system-anonymous --clusterrole=cluster-admin --user=system:anonymous

And call:
https://kubernetes.docker.internal:6443/api/v1/namespaces/application-world/services/super-important-app/proxy/goodLifeSecret
