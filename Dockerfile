###################################
#定义基础环境，后续执行在此基础上进行的，即jdk环境
FROM openjdk:8u232-stretch

#指定作者
MAINTAINER  Eric

#文件到镜像中
COPY  finalstation/  /finalstation/



#同步宿主时区
# volumes:  
#      - /etc/localtime:/etc/localtime 

#暴露给容器外的端口: http tcp udp
EXPOSE 8012 12306 12307

#执行的命令
ENTRYPOINT  ["java","-jar","-Duser.timezone=GMT+08","/finalstation/iot-app-powerMonitor-finalstation-1.0-SNAPSHOT.jar"]   