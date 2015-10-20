
FROM debian:wheezy
#mono
RUN apt-get update \
	&& apt-get install -y curl git git-core \
	&& rm -rf /var/lib/apt/lists/*

RUN apt-key adv --keyserver pgp.mit.edu --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

RUN echo "deb http://download.mono-project.com/repo/debian wheezy/snapshots/4.0.0 main" > /etc/apt/sources.list.d/mono-xamarin.list \
	&& apt-get update \
	&& apt-get install -y mono-devel ca-certificates-mono fsharp mono-vbnc nuget \
	&& rm -rf /var/lib/apt/lists/*

EXPOSE 5000


RUN cd /tmp
RUN rm -rf mono_jenkins
RUN git clone https://github.com/litealex/mono_jenkins.git
RUN cd mono_jenkins 
RUN chmod +x start.sh




CMD ["./start.sh"]