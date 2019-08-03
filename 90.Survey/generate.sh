set -ex

cd $(dirname $0)


unameOut="$(uname -s)"
case "${unameOut}" in
    Linux*)     machine=Linux;;
    Darwin*)    machine=Mac;;
    CYGWIN*)    machine=Cygwin;;
    MINGW*)     machine=MinGw;;
    windows*)   machine=Windows;;
    *)          machine="UNKNOWN:${unameOut}"
esac


PROTOC=protoc

if [ $machine = "Windows" ] ; then
  PLUGIN=protoc-gen-Tomato=Tomato-amp-link.cmd
elif [ $machine = "Cygwin" ] ; then
  PLUGIN=protoc-gen-Tomato=Tomato-amp-link.cmd
elif [ $machine = "MinGw" ] ; then
  PLUGIN=protoc-gen-Tomato=Tomato-amp-link.cmd
else
  PLUGIN=protoc-gen-Tomato=Tomato-amp-link
fi


OUT_DIR=./Survey.Protocols/_g

PROTO_DIR=./protos

if [ -d $OUT_DIR ]; then
  rm -rf $OUT_DIR
fi

mkdir -p $OUT_DIR



$PROTOC -I=$PROTO_DIR  --csharp_out=$OUT_DIR --Tomato_out=$OUT_DIR \
	$PROTO_DIR/message/*.proto $PROTO_DIR/service/*.proto --plugin=$PLUGIN

